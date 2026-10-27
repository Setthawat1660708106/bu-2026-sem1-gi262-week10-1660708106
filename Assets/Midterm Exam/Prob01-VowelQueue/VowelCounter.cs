using System;
using System.Collections.Generic;

namespace MidtermExam.Prob01
{
    public class VowelCounter
    {
        /// <summary>

        /// โค้ดที่เตรียมให้: แยกข้อความคำสั่งแล้วเรียกเมธอดของ StudentWebBrowser

        /// นักศึกษาไม่ต้องแก้ไขไฟล์นี้ ให้เขียนระบบประวัติใน StudentWebBrowser.cs

        /// </summary>

        public class BrowserNavigation

        {

            /// <summary>ประมวลผลคำสั่งที่คั่นด้วย ; โดยสร้าง browser ใหม่ทุกครั้งที่เรียก</summary>

            /// <param name="actions">

            /// รองรับ open ตามด้วย URL, back, forward และ current โดยแยกตัวพิมพ์เล็ก/ใหญ่

            /// ตัดช่องว่างรอบคำสั่งและ URL ให้แล้ว คำสั่งที่ไม่รู้จักจะถูกข้าม

            /// </param>

            /// <returns>

            /// array ของ URL ที่ได้จากคำสั่ง current ตามลำดับ หนึ่งคำสั่งต่อหนึ่งผลลัพธ์

            /// ถ้า actions เป็น null/ว่าง/ช่องว่างล้วน หรือไม่มี current จะคืน array ว่าง

            /// </returns>

            /// <remarks>ตัวอย่าง: "current; open a; current" ได้ผลลัพธ์ ["", "a"]</remarks>
            /// 
        }
            public int AS01_CountVowels(Queue<string> alphabets)
        {
            
            if (alphabets == null || alphabets.Count == 0)
            {
                return 0;
            }

            int vowelCount = 0;
            
            int totalElements = alphabets.Count;

            
            for (int i = 0; i < totalElements; i++)
            {
                
                string current = alphabets.Dequeue();

                
                if (current == "a" || current == "e" || current == "i" || current == "o" || current == "u")
                {
                    vowelCount++;
                }

                
                alphabets.Enqueue(current);
            }

            return vowelCount;
        }

    }

}

