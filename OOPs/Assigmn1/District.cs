using System;

namespace Assigmn1
{
    class Disctrict
    {

        Officer[] officersInDistrict;
        private int lastIndexOfficer = -1;


        public Disctrict(int numberOfOfficer)
        {
            this.officersInDistrict = new Officer[numberOfOfficer];
        }

        public void addOfficerToDistrict(Officer officer)
        {
            if (lastIndexOfficer == this.officersInDistrict.Length - 1)
            {
                Console.WriteLine("No more officers can be added");
                return;
            }

            lastIndexOfficer++;
            this.officersInDistrict[lastIndexOfficer] = officer;

        }

        public void removeOfficerFromDistrict(Officer officer)
        {
            int position = -1;
            foreach (Officer officerInDistrict in officersInDistrict)
            {
                position++;
                if (officerInDistrict == officer)
                {
                    if (position != this.officersInDistrict.Length - 1)
                        Array.Copy(officersInDistrict, position + 1,
                         officersInDistrict, position, officersInDistrict.Length - position-1);///shifting to right

                    this.officersInDistrict[this.lastIndexOfficer] = null;
                    this.lastIndexOfficer--;
                    return;
                }
            }
            Console.WriteLine("Officer does not exist in the district");
        }

        public int getNumberOfOfficerInDistrict()
        {
            int count = 0;
            foreach (Officer officer in this.officersInDistrict)
            {
                // if (officer != null)
                //     count++;
                if (officer == null)//if we reached empty cell of the array, we should stop
                    break;
                else
                    count++;
            }
            return count;
        }

    }

}