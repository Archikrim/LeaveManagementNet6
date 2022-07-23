using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly UserManager<Employee> _userManager;

        public LeaveRequestRepository(ApplicationDbContext context, IMapper mapper, IHttpContextAccessor httpContextAccessor, ILeaveAllocationRepository leaveAllocationRepository, UserManager<Employee> userManager) : base(context)
        {
            _context = context;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _leaveAllocationRepository = leaveAllocationRepository;
            _userManager = userManager;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model) 
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);

            var leaveRequest = _mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);
        }

        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
            return await _context.LeaveRequests.Where(x => x.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor?.HttpContext?.User);
            var allocations = (await _leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
            var requests = _mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));

            var model = new EmployeeLeaveRequestViewVM(allocations, requests);
            return model;
        }
    }
}
