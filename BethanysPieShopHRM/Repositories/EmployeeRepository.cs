﻿using BethanysPieShopHRM.Contracts.Repositories;
using BethanysPieShopHRM.Data;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Repositories
{
  public class EmployeeRepository : IEmployeeRepository, IDisposable
  {
    private readonly AppDbContext _appDbContext;

    public EmployeeRepository(IDbContextFactory<AppDbContext> DbFactory)
    {
      _appDbContext = DbFactory.CreateDbContext();
    }

   
    

    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
      return await _appDbContext.Employees.ToListAsync();
    }

    public async Task<Employee> GetEmployeeById(int employeeId)
    {
      return await _appDbContext.Employees.FirstOrDefaultAsync(c => c.EmployeeId == employeeId);
    }

    public async Task<Employee> AddEmployee(Employee employee)
    {
      var addEntity = await _appDbContext.Employees.AddAsync(employee);
      await _appDbContext.SaveChangesAsync();
      return addEntity.Entity;
    }

    public async Task<Employee> UpdateEmployee(Employee employee)
    {
      var foundEmployee = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

      if (foundEmployee != null)
      {
        foundEmployee.CountryId = employee.CountryId;
        foundEmployee.MaritalStatus = employee.MaritalStatus;
        foundEmployee.BirthDate = employee.BirthDate;
        foundEmployee.City = employee.City;
        foundEmployee.Email = employee.Email;
        foundEmployee.FirstName = employee.FirstName;
        foundEmployee.LastName = employee.LastName;
        foundEmployee.Gender = employee.Gender;
        foundEmployee.PhoneNumber = employee.PhoneNumber;
        foundEmployee.Smoker = employee.Smoker;
        foundEmployee.Street = employee.Street;
        foundEmployee.Zip = employee.Zip;
        foundEmployee.JobCategoryId = employee.JobCategoryId;
        foundEmployee.Comment = employee.Comment;
        foundEmployee.ExitDate = employee.ExitDate;
        foundEmployee.JoinedDate = employee.JoinedDate;
        foundEmployee.ImageContent = employee.ImageContent;
        foundEmployee.ImageName = employee.ImageName;

        await _appDbContext.SaveChangesAsync();

        return foundEmployee;
      }

      return null;
    }

    public async Task DeleteEmployee(int employeeId)
    {
      var foundEmployee = await _appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
      if (foundEmployee != null)
      {
        _appDbContext.Employees.Remove(foundEmployee);
        await _appDbContext.SaveChangesAsync();
      }
      return;
    }

    public void Dispose()
    {
      _appDbContext.Dispose();
    }

  }
}
