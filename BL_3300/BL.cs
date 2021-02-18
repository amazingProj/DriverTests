using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_imp : IBL
    {
        public int calculate_age(DateTime t)
        {
            // Save today's date.
            var today = DateTime.Today;
            // Calculate the age.
            var age = today.Year - t.Year;
            // Go back to the year the person was born in case of a leap year
            if (t > today.AddYears(-age)) age--;
            int _age = age;
            return _age;

        }
        #region Tester 
        bool findTester(int numberBranch)
        {

        }

        void addTester(Tester t)
        {
            if (calculate_age(t.birthday) < 40)
                throw new Exception("Wrong the tester too young");
            DAL.Idal.addTester(t);
        }

        void deleteTester(Tester t)
        {
            DAL.Idal.deleteTester(t);
        }

        List<Tester> InRange(string _address)
        {
            Random r = new Random();
            int l = r.Next(1, 500);
            List<Tester> l4 = new List<Tester>();
            foreach(Tester item in DAL.DataSource.l1)
            {
                if (item.distance < l)
                    l4.Add( item); 
            }

            return l4;
        }

       

      
     public   int ConvertDayOfWeek(DateTime t)
        {
            DateTime CloakInfoFromSystem = t;
            int day1;
            day1 = (int)CloakInfoFromSystem.DayOfWeek;
            return day1;

            }

        }
        List<Tester> ValidTester(DateTime t)
        {
            List<Tester> l5 =  DAL.DataSource.l1;
        int num =ConvertDayOfWeek(t);
            foreach (Tester item in l5)
            {
            if (item.valid[num][t.Hour - 9]) { 
                l5.Add(item);
            }
         
              
        }
        #endregion


        #region Trainee

        bool findTrainee(Tester dd) { }

        void addTrainee(Trainee od)
        {
            if (calculate_age(od.birthday)<18)
            {
                throw new Exception("Wrong the trainee too young");
            }
            DAL.Idal.addTrainee(od);

        } //הוספת מנה_מוזמנת
        void deleteTrainee(BE.Trainee o) { }   //מחיקת הזמנה
        void updateTrainee(BE.Trainee o) { }  //עדכון הזמנה
        #endregion


        #region Test
        Tester findTester(Test dd) { List<Tester> l4 = DAL.Idal.getAllTester( Tester=> DAL.DataSource.l1[i].id == dd.TesterId); if(dd.TesterId)    }
        void addTest(Test t)
        {            if (BE.Configuration.Range < 7 || BE.Configuration.minimum_NumberOfLessos<20 )
                throw new Exception("wrong you have done a test nearer");
            #region checkDate
            if (!checkValid(t))
            {
                throw new Exception("Wrong the tester is busy");
            }
            
            if (t.testDate.DayOfWeek==DayOfWeek.Sunday)
            {
               if(t.testDate.Hour)
            }
            if (t.testDate.DayOfWeek == DayOfWeek.Sunday)
            {
                t.testDate.Hour ==
              }
            if (t.valid[,)
            {
                Console.WriteLine("you can do it at" + );
            }
            #endregion
            //check how much tests
            int count = 0;
          foreach (Test ) ;
            DAL.Idal.addTest(t);
        }
        void deleteTest(Test od)//מחיקת מנה_מוזמנת
        {

        }
        void updateTest(BE.Test o)
        {

        }

    int numberOfTest(Trainee t)
    {
        int counter = 0;
        List<Test> l4 = DAL.DataSource.l3;
        foreach(Test item in l4)
        {
            if(item.studentId == t.id)
            {
                counter++;
            }
        }
        return counter;

    }
      bool eligible(Trainee t){
            int count = 4;
            foreach (Test item in DAL.DataSource.l3)
            {
                if (item.studentId == t.id)
                {
                    if (!item.StopCrossWalk)
                    {
                        item.succeeded = false;
                    }
                    else
                    {

                        if (item.keepingDistance)
                            count++;
                        if (item.mirror)
                            count++;
                        if (item.Parking)
                            count++;
                        if (item.signal)
                            count++;
                        if (item.pouncing)
                            count++;
                        if (count >= 4)
                            item.succeeded = true;
                        else item.succeeded = false;
                    }
                }
            }
        }
    #endregion

    public void checkValid(Tester t)
        {
            //icp to the boliane matrix
            if (t.valid)
                throw new Exception("the order number have to be 8 digits");
            if ((1 + t.TestCount) > t.maxTest)
                throw new Exception("the order number have to be 8 digits");
            Branch b = dal.getAllBranch(br => o.branchNumber == br.branchNumber);
            if (b == null)
                throw new Exception("this branch doesn't exist");
            if (o.hechsher != b.hechsher)
                throw new Exception("the choosed branch dosn't match the choosed hechsher"
                    );
            if ((o.clientPhoneNomber < 10000000) || (o.clientPhoneNomber > 999999999))
                throw new Exception("Wrong phone number");
            if (!(o.orderDate.Year == DateTime.Now.Year && o.orderDate.Month == DateTime.Now.Month && o.orderDate.Day == DateTime.Now.Day))
                throw new Exception("The date is not today");
            dal.addOrder(o);
        }
    }
}