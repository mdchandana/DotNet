﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {

            return await _httpClient.GetJsonAsync<Employee[]>("api/employees");

            //IEnumerable<Employee> apiResult = null;
            //apiResult= await _httpClient.GetJsonAsync<Employee[]>("api/employees");
            //var empCount = apiResult.ToList().Count;
            //return apiResult;

            //this method 'GetJsonAsync' need Microsoft.AspNetCore.Blazor.HttpClient 
            //return await _httpClient.GetJsonAsync<Employee[]>("api/employees"); 
        }


        public async Task<Employee> GetEmployee(int id)
        {
            return await _httpClient.GetJsonAsync<Employee>($"api/employees/{id}");
        }


    }
}
