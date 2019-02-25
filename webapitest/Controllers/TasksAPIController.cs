using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webapitest.Models;

namespace webapitest.Controllers
{
    public class TasksAPIController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Task> Get()
        {
            AngularTasksEntities ate = new AngularTasksEntities();
            return ate.Tasks.ToList();
        }

        // GET api/<controller>/5
        public Task Get(int id)
        {
            AngularTasksEntities ate = new AngularTasksEntities();
            return ate.Tasks.Where(a => a.quotenum == id).FirstOrDefault();
        }

        // POST api/<controller>
        public void Post(string Qtype, string contact, string task, DateTime duedate, string Ttype)
        {
            AngularTasksEntities ate = new AngularTasksEntities();
            Task t = new Task
            {
                quotetype = Qtype,
                contact = contact,
                task1 = task,
                duedate = duedate,
                tasktype = Ttype
            };
            ate.Tasks.Add(t);
            ate.SaveChanges();
        }

        // PUT api/<controller>/5
        public void Put(int id, string Qtype, string contact, string task, DateTime duedate, string Ttype)
        {
            AngularTasksEntities ate = new AngularTasksEntities();
            Task t = ate.Tasks.Where(a => a.quotenum == id).FirstOrDefault();
            if (t != null)
            {
                t.quotetype = Qtype;
                t.contact = contact;
                t.task1 = task;
                t.duedate = duedate;
                t.tasktype = Ttype;
            }
            ate.SaveChanges();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            AngularTasksEntities ate = new AngularTasksEntities();
            Task t = ate.Tasks.Where(a => a.quotenum == id).FirstOrDefault();
            if (t != null)
            {
                ate.Tasks.Remove(t);
                ate.SaveChanges();
            }
        }
    }
}