using System;
using System.Collections;
using System.Collections.Generic;
namespace OfficersDistrictDB
{
    class Disctrict
    {
        private LinkedList<Officer> officersInDistrict = new LinkedList<Officer>();
        private string name;
        private int externalId;

        public int GetExternalId()
        {
            return this.externalId;
        }

        public void SetExternalId(int extId)
        {
            this.externalId = extId;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void addOfficerToDistrict(Officer officer)
        {
            this.officersInDistrict.AddLast(officer);
        }

        public void removeOfficerFromDistrict(Officer officer)
        {
            this.officersInDistrict.Remove(officer);//THIS IS FOR LINKED LIST
        }

        public int getNumberOfOfficerInDistrict()
        {
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