using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappedMemoryConsumption
{
    public class WhenAll
    {
        public async void MethodZeroAsync()
        {
            var tasks = new List<Task>(3)
            {
                TaskOne(),
                TaskTwo(),
                TaskThree()
            };

            await Task.WhenAny(tasks);

            string ee = "";
        }

        private Task TaskOne()
        {
            return GetString();
        }

        private Task TaskTwo()
        {
            return GetString(); 
        }
        
        private Task TaskThree()
        {
            return GetString();
        }
        
        private Task GetString()
        {
            return Task.Delay(10000);
        }
    }

}
