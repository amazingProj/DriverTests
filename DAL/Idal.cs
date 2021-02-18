using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Idal
    {
        #region Tester
        bool findTester(int numberBranch);
        void addTester(Tester t);
        void deleteTester(Tester t);
        void updateTester(Tester t);
        IEnumerable<Tester> getAllTesters(Func<Tester, bool> predicat = null);//בוחנים
        #endregion
        #region Trainee
        bool findTrainee(Trainee dd);
        void addTrainee(Trainee od);  //הוספת מנה_מוזמנת
        void deleteTrainee(BE.Trainee o);   //מחיקת הזמנה
        void updateTrainee(BE.Trainee o);  //עדכון הזמנה
        IEnumerable<Trainee> getAllTrainees(Func<Tester, bool> predicat = null);//נבחנים
        #endregion
        #region Test

        bool findTest(Test dd);
        void addTest(Test y);
        void deleteTest(Test od);  //מחיקת מנה_מוזמנת
        void updateTest(BE.Test o);  //עדכון הזמנה
        IEnumerable<Test> getAllTests(Func<Tester, bool> predicat = null);//מבחנים
        #endregion


    }
}