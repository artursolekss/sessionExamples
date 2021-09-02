using System;

namespace OfficersDistrictDB
{

    public class Officer
    {

        private Officer previousOfficer;///the reference to the previous officer in the list is stored here
        private Officer nextOfficer;///the reference to the next officer in the list is stored here
        private string name, surname;
        private int workingDistrictId;
        public string WorkingDistrictExtId
        {
            get { return WorkingDistrictExtId; }
            set { this.WorkingDistrictExtId = value; }
        }
        private int officerID, crimesSolved;

        public Officer()
        {
            ///No-argument constructor
        }

        public Officer getNext()
        {
            return this.nextOfficer;
        }

        public Officer getPrevious()
        {
            return this.previousOfficer;
        }

        public void removeOfficer()//remove the current officer from the list
        {
            this.previousOfficer.nextOfficer = this.nextOfficer;
            this.nextOfficer.previousOfficer = this.previousOfficer;
        }

        public void addOfficer(Officer officer)
        {
            if (this.nextOfficer != null)
            {
                this.nextOfficer.previousOfficer = officer;
            }

            officer.nextOfficer = this.nextOfficer;
            this.nextOfficer = officer;
            officer.previousOfficer = this;

        }

        public void addOfficerAtStart(Officer officer)
        {
            if (this.previousOfficer == null)
            {
                this.previousOfficer = officer;
                officer.nextOfficer = this.previousOfficer;
            }
            else
                officer.addOfficerAtStart(officer);
        }

        public void addOfficerAtTheEnd(Officer officer)
        {
            if (this.nextOfficer == null)
            {
                this.nextOfficer = officer;
                officer.previousOfficer = this;//for the next officer in the list, the previous one will be the current one
            }
            else
                this.nextOfficer.addOfficerAtTheEnd(officer);
        }

        //Parameterized constructor
        public Officer(string name, string surname, int workingDistrict, int officerID, int crimesSolved)
        {
            this.crimesSolved = crimesSolved;
            this.name = name;
            this.surname = surname;
            this.workingDistrictId = workingDistrict;
            this.officerID = officerID;
        }

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getSurname()
        {
            return this.surname;
        }
        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public int getWorkingDistrictExtId()
        {
            return this.workingDistrictId;
        }

        public void setWorkingDistrict(int workingDistrictId)
        {
            this.workingDistrictId = workingDistrictId;
        }

        public int getOfficerId()
        {
            return this.officerID;
        }

        public void setOfficerId(int officerID)
        {
            this.officerID = officerID;
        }

        public int getCrimesSolved()
        {
            return this.crimesSolved;
        }

        public void setCrimesSolved(int crimesSolved)
        {
            this.crimesSolved = crimesSolved;
        }

        public override string ToString()
        {
            return "Name : " + this.name + "\n" +
           "Surname : " + this.surname + "\n" +
          "District : " + this.workingDistrictId + "\n" +
            "Officer ID : " + this.officerID + "\n" +
           "Crimes Solved : " + this.crimesSolved + "\n" +
           "Level : " + this.calculatedLevel();
        }


        public int calculatedLevel()
        {
            if (this.crimesSolved < 20)
                return 1;
            if (this.crimesSolved < 40)
                return 2;
            else
                return 3;

        }

        public static int getCountByLevel(int level, Officer[] officers)
        {
            int count = 0;
            foreach (Officer officer in officers)
            {
                if (officer == null)///means that the cell of the array is empty
                    continue;//go to the next iteration of the loop

                if (officer.calculatedLevel() == level)
                    count++;
            }
            return count;
        }

        public static int getCountByLevelMore(int level, Officer[] officers)
        {
            int count = 0;
            foreach (Officer officer in officers)
            {
                if (officer == null)///means that the cell of the array is empty
                    continue;//go to the next iteration of the loop

                if (officer.calculatedLevel() > level)
                    count++;
            }
            return count;
        }

        public static bool checkNameExist(string name, Officer[] officers)
        {
            foreach (Officer officer in officers)
            {
                if (officer == null)///means that the cell of the array is empty
                    continue;//go to the next iteration of the loop

                if (officer.getName().Equals(name))
                    return true;
            }
            return false;
        }

    }

}
