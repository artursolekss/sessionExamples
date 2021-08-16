using System;
using System.Collections;
using System.Collections.Generic;
namespace Assigmn1
{
    class Disctrict
    {
        // private Officer[] officersInDistrict;
        // private ArrayList officersInDistrict = new ArrayList();
        private LinkedList<Officer> officersInDistrict = new LinkedList<Officer>();
        // private int lastIndexOfficer = -1;

        // public Disctrict(int numberOfOfficer)
        // {
        //     this.officersInDistrict = new Officer[numberOfOfficer];
        // }

        public void addOfficerToDistrict(Officer officer)
        {
            // this.officersInDistrict.Add(officer);//this is for ArrayList
            this.officersInDistrict.AddLast(officer);///this is for LinkedList
            // if (lastIndexOfficer == this.officersInDistrict.Length - 1)
            // {
            //     Console.WriteLine("No more officers can be added");
            //     return;
            // }

            // this.lastIndexOfficer++;
            // this.officersInDistrict[this.lastIndexOfficer] = officer;

        }

        public void removeOfficerFromDistrict(Officer officer)
        {
            // this.officersInDistrict.Remove(officer);/// THIS IS FOR ARRAY LIST
            this.officersInDistrict.Remove(officer);//THIS IS FOR LINKED LIST
            // int position = -1;
            // foreach (Officer officerInDistrict in officersInDistrict)
            // {
            //     position++;
            //     if (officerInDistrict == officer)
            //     {
            //         if (position != this.officersInDistrict.Length - 1)
            //             Array.Copy(officersInDistrict, position + 1,
            //              officersInDistrict, position, officersInDistrict.Length - position - 1);///shifting to right

            //         this.officersInDistrict[this.lastIndexOfficer] = null;///no reference to the object placed under the element of the array
            //         this.lastIndexOfficer--;
            //         return;
            //     }
            // }
            // Console.WriteLine("Officer does not exist in the district");
        }

        public int getNumberOfOfficerInDistrict()
        {
            // int count = 0;
            // foreach (Officer officer in this.officersInDistrict)
            // {
            //     // if (officer != null)
            //     //     count++;
            //     if (officer == null)//if we reached empty cell of the array, we should stop
            //         break;
            //     else
            //         count++;
            // }
            // return count;

            // return this.lastIndexOfficer + 1;
            return this.officersInDistrict.Count;
        }

        public float calculateAvgLevelInDistrict()
        {
            int sum = 0;
            foreach (Officer officer in this.officersInDistrict)
            {
                if (officer == null)
                    break;
                sum += officer.calculatedLevel();
            }
            return (float)sum / (float)this.getNumberOfOfficerInDistrict();
        }

    }

}