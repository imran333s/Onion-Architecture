using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository) => _repository = repository;

        public IEnumerable<StudentDTO> GetAllStudents() =>
            _repository.GetAll().Select(s => new StudentDTO
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                Gender = s.Gender,
                Address = s.Address
            });

        public StudentDTO GetStudentById(int id)
        {
            var s = _repository.GetById(id);
            return s == null ? null : new StudentDTO
            {
                FirstName = s.FirstName,
                LastName = s.LastName,
                Gender = s.Gender,
                Address = s.Address
            };
        }

        public void AddStudent(StudentDTO dto)
        {
            var student = new Student
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Gender = dto.Gender,
                Address = dto.Address
            };
            _repository.Add(student);
        }

        public void UpdateStudent(int id, StudentDTO dto)
        {
            var student = _repository.GetById(id);
            if (student == null) return;

            student.FirstName = dto.FirstName;
            student.LastName = dto.LastName;
            student.Gender = dto.Gender;
            student.Address = dto.Address;

            _repository.Update(student);
        }

        public void DeleteStudent(int id) => _repository.Delete(id);
    }
}
