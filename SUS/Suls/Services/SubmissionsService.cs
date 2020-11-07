﻿using Suls.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Suls.Services
{
    public class SubmissionsService : ISubmissionsService
    {
        private readonly ApplicationDbContext db;
        private readonly Random random;

        public SubmissionsService(ApplicationDbContext db, Random random)
        {
            this.db = db;
            this.random = random;
        }
        public void Create(string problemId, string userId, string code)
        {
            var problemMaxPoints = this.db.Problems.Where(x => x.Id == problemId).Select(x => x.Points).FirstOrDefault();
            var submission = new Submission
            {
                Code = code,
                ProblemId = problemId,
                UserId = userId,
                CreatedOn = DateTime.UtcNow,
                AchievedResult = this.random.Next(0, problemMaxPoints + 1)
            };
            this.db.Submissions.Add(submission);
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            var submission = this.db.Submissions.FirstOrDefault(x => x.Id == id);
            this.db.Submissions.Remove(submission);
            this.db.SaveChanges();
        }
    }
}
