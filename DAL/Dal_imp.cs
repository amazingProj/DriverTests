using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Dal_imp : Idal
    {
        #region Tester
        public bool findTester(int numberId)
        {
            if (DataSource.l1.Count == 0)
                return false;
            foreach (Tester item in DataSource.l1)
                if (numberId == item.id)
                    return true;
            return false;
        }

        public void addTester(Tester t)
        {
            bool flag = findTester(t.id);
            if (flag)
            {
                DataSource.l1.Add(t);
            }
            else
                throw new Exception("this Tester is already exsits");
        }
        public void deleteTester(Tester t)
        {
            if (findTester(t.id))
                DataSource.l1.RemoveAll(d => d.id == t.id);
            else
                throw new Exception("this Tester's id is invalid");
        }
        public void updateTester(Tester t)
        {
            for (int i = 0; i < DataSource.l1.Count; i++)
                if (DataSource.l1[i].id == t.id)
                    DataSource.l1[i] = t;
            throw new Exception("this Tester's id is not exist");
        }
        IEnumerable<BE.Tester> getAllTesters(Func<BE.Tester, bool> predicat = null)
        {

            if (DataSource.l1 != null)
            {
                return DataSource.l1;
            }
            throw new Exception("There is no Tester in the data source ");

        }
        #endregion
        #region Trainee
        public bool findTrainee(int numberId)
        {
            if (DataSource.l2.Count == 0)
                return false;
            foreach (Tester item in DataSource.l1)
                if (numberId == item.id)
                    return true;
            return false;
        }

        public void addTrainee(Trainee t)
        {
            bool flag = findTester(t.id);
            if (flag)
            {
                DataSource.l2.Add(t);
            }
            else
                throw new Exception("this Trainee is already exsits");
        }
        public void deleteTrainee(Trainee t)
        {
            if (findTrainee(t.id))
                DataSource.l2.RemoveAll(d => d.id == t.id);
            else
                throw new Exception("this Trainee's id is invalid");
        }
        public void updateTrainee(Trainee t)
        {
            for (int i = 0; i < DataSource.l2.Count; i++)
                if (DataSource.l2[i].id == t.id)
                    DataSource.l2[i] = t;
            throw new Exception("this Trainee's id is not exist");
        }
        IEnumerable<BE.Trainee> getAllTrainees(Func<BE.Tester, bool> predicat = null)
        {//נבחנים
            if (DataSource.l2 != null)
            {
                return DataSource.l2;
            }
            throw new Exception("There is no Trainee in the data source ");
        }
       
       
        //בוחנים
        #endregion
        #region Test
        public bool findTest(int numberId)
        {
            if (DataSource.l3.Count == 0)
                return false;
            foreach (Test item in DataSource.l3)
                if (numberId == item.TestNumber)
                    return true;
            return false;
        }

        public void addTest(Test t)
        {
            bool flag = findTester(t.TestNumber);
            if (flag)
            {
                DataSource.l3.Add(t);
            }
            else
                throw new Exception("this Test is already exsits");
        }
        public void deleteTest(Test t)
        {
            if (findTrainee(t.id))
                DataSource.l2.RemoveAll(d => d.id == t.id);
            else
                throw new Exception("this Test's number is invalid");
        }
        public void updateTest(Test t)
        {
            for (int i = 0; i < DataSource.l3.Count; i++)
                if (DataSource.l3[i].TestNumber == t.TestNumber)
                    DataSource.l3[i] = t;
            throw new Exception("this Test's number is not exist");
        }
        IEnumerable<BE.Test> getAllTests(Func<BE.Tester, bool> predicat = null)
        {
            if (DataSource.l3 != null)
            {
                return DataSource.l3;
            }
            throw new Exception("There is no Test in the data source ");
        }//מבחנים
        #endregion
    }