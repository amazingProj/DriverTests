using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IBL
    {
        int calculate_age(DateTime t);
        #region Tester
        bool findTester(int numberBranch);
        void addTester(Tester t);
        void deleteTester(Tester t);
        void updateTester(Tester t);
        IEnumerable<Tester> getAllTester(Func<Tester, bool> predicat = null);//בוחנים
        List<Tester> InRange(string _address);

        #endregion
        #region Trainee
        bool findTrainee(Trainee dd);
        void addTrainee(Trainee od);  //הוספת מנה_מוזמנת
        void deleteTrainee(BE.Tester o);   //מחיקת הזמנה
        void updateTrainee(BE.Tester o);  //עדכון הזמנה
        IEnumerable<Trainee> getAllTrainee(Func<Tester, bool> predicat = null);//נבחנים
        int numberOfTest(Trainee t);
        bool  eligible(Trainee t);
        #endregion
        #region Test

        bool findTest(Test dd);
        void addTest(Test y);
        void deleteTest(Test od);  //מחיקת מנה_מוזמנת
        IEnumerable<Test> getAllTest(Func<Tester, bool> predicat = null);//מבחנים
        #endregion
        
    }
}

