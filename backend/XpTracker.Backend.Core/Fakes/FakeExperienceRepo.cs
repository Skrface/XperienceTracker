using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Repo;

namespace XpTracker.Backend.Core.Fakes
{
    /// <summary>
    /// Fake Experience repo
    /// </summary>
    internal class FakeExperienceRepo : FakeBaseRepo<Experience>, IExperienceRepo
    {
        List<Experience> otherInMemoryStorage = null;

        public FakeExperienceRepo(IExperienceRepo experienceInquiry)
        {
            if (experienceInquiry is FakeExperienceRepo repo)
            {
                this.otherInMemoryStorage = FakeExperienceRepo._inMemoryStorage;
            }
        }

        public override IQueryable<Experience> FindBy(Expression<Func<Experience, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }

        public override void Create(Experience entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Experience entity)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Experience> GetAll()
        {
            List<Experience> experiences = otherInMemoryStorage.ToList();
            return experiences.AsQueryable();
        }

        public override void Refresh(Experience entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(Experience entity)
        {
            throw new NotImplementedException();
        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
