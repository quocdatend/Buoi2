using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>(); ;
            Console.WriteLine("Nhap thong tin sinh vien!");
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Sinh vien thu {0}", i + 1);
                Student newSt = new Student();
                newSt.Input();
                st.Add(newSt);
            }
            Console.WriteLine("In thong tin sinh vien!");
            for(int i = 0;i<5; i++)
            {
                Console.WriteLine("Sinh vien thu {0}", i + 1);
                st[i].Output();
            }
            List<Student> ageSt = new List<Student>();
            ageSt.AddRange(st.Where(x=>x.Age >= 15 && x.Age <= 18));
            Console.WriteLine("Thong tin sinh vien co tuoi tu 15 den 18");
            foreach (Student student in ageSt)
            {
                student.Output();
            }
            List<Student> nameSt = new List<Student>();
            nameSt.AddRange(st.Where(x => x.Name[0].Equals("A")));
            Console.WriteLine("Thong tin sinh vien co ten bat dau bang chu A");
            foreach (Student student in ageSt)
            {
                student.Output();
            }
            int tongTuoi = 0;
            foreach (Student student in st)
            {
                tongTuoi += student.Age;
            }
            Console.WriteLine("Tong tuoi cua tat ca cac hoc sinh trong danh sach la: {0}", tongTuoi);
            int tuoiMax = st[0].Age;
            Student tuoiMaxSt = st[0];
            foreach(Student student in st)
            {
                if(student.Age > tuoiMax)
                {
                    tuoiMax = student.Age;
                    tuoiMaxSt = student;
                }
            }
            Console.WriteLine("Hoc sinh co tuoi lon nhat la: ");
            tuoiMaxSt.Output();
        }
    }
}
