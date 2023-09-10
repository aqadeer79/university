using System;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.RabbitMQ;
using StudentAPI.Services;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private readonly IStudentService studentService;
        private readonly IMessageProducer messageProducer;

        public StudentController(IStudentService studentService, IMessageProducer messageProducer)
        {
            this.studentService = studentService;
            this.messageProducer = messageProducer;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<Student> GetAllStudents()
        {
            var students = studentService.GetAllStudents();
            Student? student = students.FirstOrDefault();
            messageProducer.SendMessage(student);
            return students;
        }
    }
}

