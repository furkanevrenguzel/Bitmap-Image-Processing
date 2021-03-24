using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GaMP_InternProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WhatsTheTimeController : ControllerBase
    {
        public static string WhatsTime(string bitmap) //Function
        {
            List<int> binary = new List<int>() { 31599, 11415, 29671, 29647, 23497, 31183, 18927, 29257, 31727, 31689 }; 
            // It is the decimal equivalent of binary code, which visually corresponds to the numbers represented by bitmap pixels. It represents "0,1,2,3,4,5,6,7,8,9" respectively. 
            List<string> array = new List<string>();
            for (int i = 0; i < 5; i++) //Split a 5 cell deep bitmap cell into rows.
            {
                array.Add(bitmap.Substring(i * 17, 17)); //Binary numbers are taken in 17 bit order.
            }
            string s1 = "", s2 = "", s3 = "", s4 = "";
            for (int i = 0; i < array.Count; i++) //Separating each row 3 cells wide and concatenating them into a string.
            {
                s1 += array[i].Substring(0, 3); //First digit of the clock. 3 characters starting from 0.
                s2 += array[i].Substring(4, 3); //Second digit of the clock. 3 characters starting from 4
                s3 += array[i].Substring(10, 3); //First digit of the minute. 3 characters starting from 10.
                s4 += array[i].Substring(14, 3); //Second digit of the minute. 3 characters starting from 14.
            }
            return string.Concat(binary.FindIndex(i => i == Convert.ToInt32(s1, 2)), binary.FindIndex(i => i == Convert.ToInt32(s2, 2)),":"
                , binary.FindIndex(i => i == Convert.ToInt32(s3, 2)), binary.FindIndex(i => i == Convert.ToInt32(s4, 2))); 
            //We convert the binary number array we have obtained to decimal, search the list named binary and print the index number after it is found.
        }

        [HttpGet] //Calling the value from the function to be printed on the screen to be returned with HttpGet.
        public IEnumerable<WhatsTheTime> Get()
        {
            /*
                "111 0 010 000 111 0 111" +
                "101 0 110 010 001 0 100" +
                "101 0 010 000 111 0 111" +
                "101 0 010 010 001 0 001" +
                "111 0 111 000 111 0 111")
            */
            yield return new WhatsTheTime { Time = (string)WhatsTime("1110010000111011110101100100010100101001000011101111010010010001000111101110001110111") }; 
            //The 0-1 equivalents of the pixels obtained from the bitmap are sent to the function. The resulting result is printed on the screen.
        }
    }
}
