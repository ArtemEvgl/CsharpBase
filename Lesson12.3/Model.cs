using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._3
{
    class Model
    {
        List<int> numbers = new List<int>();
        OperationEnum lastOperation;

        public string Calculate(string parameter, OperationEnum operationEnum)
        {
            lastOperation = operationEnum;
            if (Int32.TryParse(parameter, out int number))
            {
                numbers.Add(number);
                int result;
                if (numbers.Count == 1)
                {
                    result = 0;
                }
                else
                {
                    result = ExecuteOperation(false);
                }
                return result.ToString();
            } else
            {
                return "Введите число";
            }
            
        }

        private int ExecuteOperation(bool finishResult)
        {
            int result;
            switch(lastOperation)
            {
                case OperationEnum.Div:
                    result = numbers[0] / numbers[1];
                    break;
                case OperationEnum.Add:
                    result = numbers[0] + numbers[1];
                    break;
                case OperationEnum.Mul:
                    result = numbers[0] * numbers[1];
                    break;
                case OperationEnum.Sub:
                    result = numbers[0] - numbers[1];
                    break;
                default:
                    result = numbers[0];
                    break;
            }
            numbers.Clear();
            if(!finishResult)
                numbers.Add(result);
            return result;
        }

        public string GetResult(string parameter)
        {
            
            if (Int32.TryParse(parameter, out int number))
            {
                int result;
                if (numbers.Count > 0)
                {
                    numbers.Add(number);
                    result = ExecuteOperation(true);
                }
                else
                {
                    result = 0;
                }
                return result.ToString();
            } else
            {
                return "Введите число";
            }
        }
    }
}
