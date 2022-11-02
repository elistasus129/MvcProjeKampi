using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        
        public Skill GetByID(int id)
        {
            return _skillDal.Get(x => x.SkillID == id);
        }

        public List<Skill> GetList()
        {
            return _skillDal.List();
        }

        public List<Skill> GetList(string p)
        {
            return _skillDal.List(x => x.SkillName == p);
        }

        public List<Skill> GetListBySkill(int id)
        {
            return _skillDal.List(x => x.SkillID == id);
        }

        public void SkillAdd(Skill skill)
        {
            _skillDal.Insert(skill);
        }

        public void SkillDelete(Skill skill)
        {
            _skillDal.Delete(skill);
        }

        public void SkillUpdate(Skill skill)
        {
            _skillDal.Update(skill);
        }
    }
}
