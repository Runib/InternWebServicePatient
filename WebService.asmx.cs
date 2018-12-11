using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace WebServicePatient
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    [SoapDocumentService(RoutingStyle = SoapServiceRoutingStyle.RequestElement)]
    public class WebService : System.Web.Services.WebService, IMyWebService_Binding
    {
        public static List<Patient> patientList = new List<Patient>
        {
            new Patient { DOB = DateTime.Now, Email="sialala", FirstName="Raf", MRN="12", SecondName="ajaja", Sex="Male" },
            new Patient { DOB = DateTime.Now, Email="sialala", FirstName="Rafdw", MRN="13", SecondName="ajaja", Sex="Male" },
            new Patient { DOB = DateTime.Now, Email="sialala", FirstName="Rafdwa", MRN="14", SecondName="ajaja", Sex="Male" },
            new Patient { DOB = DateTime.Now, Email="sialala", FirstName="Rafdwada", MRN="15", SecondName="ajaja", Sex="Male"  },
            new Patient { DOB = DateTime.Now, Email="sialala", FirstName="Rafdwadaw", MRN="16", SecondName="ajaja", Sex="Male"  },
            new Patient { DOB = DateTime.Now, Email="sialala", FirstName="Rafbv", MRN="17", SecondName="ajaja", Sex="Male"}
        };

        public static List<Order> orderList = new List<Order>
        {
            new Order { EndDate = DateTime.Now, OrderNumber=1, StartDate=DateTime.Now ,  patientMRN="12"},
            new Order { EndDate = DateTime.Now, OrderNumber=2, StartDate=DateTime.Now ,  patientMRN="12" },
            new Order { EndDate = DateTime.Now, OrderNumber=3, StartDate=DateTime.Now ,  patientMRN="12"},
            new Order { EndDate = DateTime.Now, OrderNumber=4, StartDate=DateTime.Now ,  patientMRN="13"},
            new Order { EndDate = DateTime.Now, OrderNumber=5, StartDate=DateTime.Now ,  patientMRN="13"},
            new Order { EndDate = DateTime.Now, OrderNumber=6, StartDate=DateTime.Now ,  patientMRN="13"},
            new Order { EndDate = DateTime.Now, OrderNumber=7, StartDate=DateTime.Now ,  patientMRN="14" },
            new Order { EndDate = DateTime.Now, OrderNumber=8, StartDate=DateTime.Now ,  patientMRN="14"},
            new Order { EndDate = DateTime.Now, OrderNumber=9, StartDate=DateTime.Now ,  patientMRN="14"},
            new Order { EndDate = DateTime.Now, OrderNumber=10, StartDate=DateTime.Now , patientMRN="15"},
            new Order { EndDate = DateTime.Now, OrderNumber=11, StartDate=DateTime.Now , patientMRN="15"},
            new Order { EndDate = DateTime.Now, OrderNumber=12, StartDate=DateTime.Now , patientMRN="15"},
            new Order { EndDate = DateTime.Now, OrderNumber=13, StartDate=DateTime.Now , patientMRN="16"},
            new Order { EndDate = DateTime.Now, OrderNumber=14, StartDate=DateTime.Now , patientMRN="16"},
            new Order { EndDate = DateTime.Now, OrderNumber=15, StartDate=DateTime.Now , patientMRN="16" },
            new Order { EndDate = DateTime.Now, OrderNumber=16, StartDate=DateTime.Now , patientMRN="17"},
            new Order { EndDate = DateTime.Now, OrderNumber=17, StartDate=DateTime.Now , patientMRN="17"},
            new Order { EndDate = DateTime.Now, OrderNumber=18, StartDate=DateTime.Now , patientMRN="17"}
        };

        public static List<Title> titleList = new List<Title>
        {
            new Title { Title1="Blood", TitleId=1 },
            new Title { Title1="Leg", TitleId=2 },
            new Title { Title1="Kameleon", TitleId=3 },
            new Title { Title1="SinglePlayer", TitleId=4 },
            new Title { Title1="Mleko", TitleId=5 },
            new Title { Title1="ajawlasnie", TitleId=6 },
            new Title { Title1="Kot", TitleId=7 }
        };

        public static List<Test> testList = new List<Test>
        {
            new Test { SpecimenCode="12121212", TestId=1, Type="a" , Priority=1,isSelected=false , OrderNumber=1, TitleId=1},
            new Test { SpecimenCode="12121212", TestId=2, Type="b" , Priority=2, isSelected=false, OrderNumber=1 ,TitleId=2},
            new Test { SpecimenCode="12121212", TestId=3, Type="c" , Priority=3, isSelected=false , OrderNumber=2,TitleId=3},
            new Test { SpecimenCode="12121212", TestId=4, Type="d" , Priority=4, isSelected=false , OrderNumber=2,TitleId=4},
            new Test { SpecimenCode="12121212", TestId=5, Type="e" , Priority=5, isSelected=false , OrderNumber=3,TitleId=5},
            new Test { SpecimenCode="12121212", TestId=6, Type="f" , Priority=1, isSelected=false , OrderNumber=3,TitleId=6},
            new Test { SpecimenCode="12121212", TestId=7, Type="g" , Priority=2, isSelected=false, OrderNumber=4 ,TitleId=7},
            new Test { SpecimenCode="12121212", TestId=8, Type="h" , Priority=3, isSelected=false , OrderNumber=4,TitleId=1},
            new Test { SpecimenCode="12121212", TestId=9, Type="e" , Priority=4, isSelected=false , OrderNumber=5,TitleId=2},
            new Test { SpecimenCode="12121212", TestId=10, Type="i" , Priority=5, isSelected=false , OrderNumber=5,TitleId=3},
            new Test { SpecimenCode="12121212", TestId=11, Type="j" , Priority=1,  isSelected=false , OrderNumber=6,TitleId=4},
            new Test { SpecimenCode="12121212", TestId=12, Type="k" , Priority=2, isSelected=false, OrderNumber=7 ,TitleId=5},
            new Test { SpecimenCode="12121212", TestId=13, Type="l" , Priority=3, isSelected=false , OrderNumber=8,TitleId=6},
            new Test { SpecimenCode="12121212", TestId=14, Type="m" , Priority=4, isSelected=false , OrderNumber=9,TitleId=7},
            new Test { SpecimenCode="12121212", TestId=15, Type="n" , Priority=5, isSelected=false , OrderNumber=10,TitleId=1},
            new Test { SpecimenCode="12121212", TestId=16, Type="o" , Priority=2, isSelected=false, OrderNumber=11 ,TitleId=2},
            new Test { SpecimenCode="12121212", TestId=17, Type="p" , Priority=3, isSelected=false , OrderNumber=12,TitleId=3},
            new Test { SpecimenCode="12121212", TestId=18, Type="r" , Priority=4, isSelected=false , OrderNumber=13,TitleId=4},
            new Test { SpecimenCode="12121212", TestId=19, Type="s" , Priority=5, isSelected=false , OrderNumber=14, TitleId=5},
            new Test { SpecimenCode="12121212", TestId=20, Type="t" , Priority=1, isSelected=false , OrderNumber=15,TitleId=6},
            new Test { SpecimenCode="12121212", TestId=21, Type="w" , Priority=2, isSelected=false, OrderNumber=16 ,TitleId=7},
            new Test { SpecimenCode="12121212", TestId=22, Type="x" , Priority=3, isSelected=false , OrderNumber=17, TitleId=1},
            new Test { SpecimenCode="12121212", TestId=23, Type="q" , Priority=4, isSelected=false , OrderNumber=18,TitleId=2}
        };


        [WebMethod]
        [return: XmlElement("AllPatientResponse")]
        public Patient[] LoadAllPatientData()
        {
            return patientList.ToArray();
        }

        [WebMethod]
        [return: XmlElement("PatientData")]
        public Patient LoadPatientData(string PatientMrn)
        {
            return patientList.First(patient => patient.MRN == PatientMrn);
        }

        [WebMethod]
        [return: XmlElement("outCreatePatient")]
        public bool CreatePatientData(Patient Patient)
       {
            if (Patient == null)
                return false;
            else
            {
                if (patientList.FirstOrDefault(p => p.MRN == Patient.MRN) == null)
                {
                    patientList.Add(Patient);
                    return true;
                }
                else
                    return false; 
            }
        }

        [WebMethod]
        [return: XmlElement("outUpdatePatient")]
        public bool UpdatePatientData(string MRN, string FirstName, string SecondName, DateTime DOB, Boolean DOBSpecified, string Sex, string Email)
        {
            var updatePatient = patientList.FirstOrDefault(d => d.MRN == MRN);
            if (updatePatient != null)
            {
                if (FirstName != updatePatient.FirstName)
                    updatePatient.FirstName = FirstName;
                if (SecondName != updatePatient.SecondName)
                    updatePatient.SecondName = SecondName;
                if (DOB != updatePatient.DOB)
                    updatePatient.DOB = DOB;
                if (Sex != updatePatient.Sex)
                    updatePatient.Sex = Sex;
                if (Email != updatePatient.Email)
                    updatePatient.Email = Email;

                return true;
            }
            else
                return false;
        }

        [WebMethod]
        [return: XmlElement("outDeletePatient")]
        public bool DeletePatientData(string MRN)
        {
            var patientObject = patientList.First(s => s.MRN == MRN);
            if (patientObject != null)
            {
                patientList.Remove(patientObject);
                List<Order> removeOrderList = orderList.Where(o => o.patientMRN == patientObject.MRN).ToList();
                try
                {
                    foreach (var item in removeOrderList)
                    {
                        orderList.Remove(item);
                        testList.RemoveAll(o => o.OrderNumber == item.OrderNumber);
                    }
                }
                catch (Exception)
                {

                }
                
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        [return: XmlElement("OrderData")]
        public Order[] LoadAllOrderData()
        {
            return orderList.ToArray();
        }

        [WebMethod]
        [return: XmlElement("OrderData")]
        public Order[] LoadOrderData(string PatientMrn)
        {
            return orderList.Where(p => p.patientMRN == PatientMrn).ToArray();
        }



        [WebMethod]
        [return: XmlElement("Test")]
        public Test[] LoadAllTestData()
        {
            return testList.ToArray();
        }

        [WebMethod]
        [return: XmlElement("TestData")]
        public Test[] LoadTestData(int OrderNumber)
        {
            return testList.Where(testt => testt.OrderNumber == OrderNumber).ToArray();
        }

        [WebMethod]
        [return: XmlElement("outCreateTest")]
        public bool CreateTestData(Test Test)
        {
            if (Test == null)
                return false;
            else
            {
                var cc= testList.Max(w => w.TitleId);
                Test.TestId = testList.Max(w => w.TitleId)+1;
                testList.Add(Test);
                return true;
            }
        }

        [WebMethod]
        [return: XmlElement("outDeleteTest")]
        public bool DeleteTestData(int TestId)
        {
            var testObject = testList.First(s => s.TestId == TestId);
            if (testObject != null)
            {
                testList.Remove(testObject);
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        [return: XmlElement("outCreateOrder")]
        public bool CreateOrderData(Order Order, string PatientMrn)
        {
            if (Order == null)
                return false;
            else
            {
                if (PatientMrn != null)
                {
                    var kk = orderList.Max(w => w.OrderNumber);
                    Order.OrderNumber = orderList.Max(w=>w.OrderNumber) + 1;
                    Order.patientMRN = PatientMrn;
                    orderList.Add(Order);
                }
                else
                    orderList.Add(Order);

                return true;
            }
        }

        [return: XmlElement("outCheckPatient")]
        public bool EqualsPatient(Patient Patient)
        {

            var patientFirst = patientList.First(pat => pat.MRN == Patient.MRN);

            if (patientFirst != null)
            {
                if (patientFirst.FirstName == Patient.FirstName && patientFirst.SecondName == Patient.SecondName && patientFirst.DOB.Date == Patient.DOB.Date
                    && patientFirst.Email == Patient.Email && patientFirst.Sex == Patient.Sex)
                    return true;
                else return false;
            }
            else return false;
        }

        [return: XmlElement("PatientData")]
        public Patient LoadPatientDataByOrder(Order OrderData)
        {
            string patMRN = orderList.FirstOrDefault(ord => ord.OrderNumber == OrderData.OrderNumber).patientMRN;
            return patientList.FirstOrDefault(pat => pat.MRN == patMRN);
        }

        [WebMethod]
        [return: XmlElement("outDeleteOrder")]
        public bool DeleteOrderData(Order Order)
        {
            var searchOrder = orderList.FirstOrDefault(ord => ord.OrderNumber == Order.OrderNumber);
            if (searchOrder != null)
            {
                var searchTest = testList.FirstOrDefault(tes => tes.OrderNumber == searchOrder.OrderNumber);
                orderList.Remove(searchOrder);
                testList.Remove(searchTest);
                return true;
            }
            else
                return false;
        }

        [WebMethod]
        [return: XmlElement("outClearTest")]
        public bool ClearAllTest()
        {
            foreach (var test in testList)
            {
                test.isSelected = false;
            }
            return true;
        }

        [WebMethod]
        [return: XmlElement("outUpdateTest")]
        public bool UpdateSelectedTests(Test[] TestList)
        {
            foreach (var test in TestList)
            {
                testList.FirstOrDefault(t => t.TestId == test.TestId).isSelected = test.isSelected;
            }
            return true;
        }

        [WebMethod]
        [return: XmlElement("AllTitle")]
        public Title[] LoadAllTitle()
        {
            return titleList.ToArray();
        }

        [WebMethod]
        [return: XmlElement("Title")]
        public string LoadTitle(int TitleId)
        {
            return titleList.First(t => t.TitleId == TitleId).Title1;
        }

        [WebMethod]
        [return: XmlElement("TitleId")]
        public int LoadTitleId(string Title)
        {
            return titleList.First(t => t.Title1 == Title).TitleId;
        }

        [WebMethod]
        [return: XmlElement("LastIndex")]
        public int NextIdOrder()
        {
            var cos = orderList.Max(p => p.OrderNumber);
            return cos+1;
        }

        [WebMethod]
        [return: XmlElement("OrderData")]
        public Order[] LoadOrderDataByOrderNumber(int OrderNumber)
        {
            return orderList.FindAll(o => o.OrderNumber == OrderNumber).ToArray();
        }
    }
}
