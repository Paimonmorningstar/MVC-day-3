using Day3.Models;

namespace Day3.Services
{
    public class PersonServiceExtended : IPersonService
    {
        private static List<PersonModel> _people = new List<PersonModel>{
             new PersonModel{
                FirstName = "Loc",
                LastName  = "Nguyen Thanh",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,01,21),
                PhoneNumber="0961564730",
                BirthPlace = "Bac Ninh",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Hung",
                LastName  = "Vu Trong",
                Gender = "Male",
                DateOfBirth = new DateTime(2000,07,06),
                PhoneNumber="00223344885",
                BirthPlace = "Lao Cai",
                IsGraduated = false
            },
            new PersonModel{
                FirstName = "Linh",
                LastName  = "Nguyen Nhat",
                Gender = "Female",
                DateOfBirth = new DateTime(2000,07,24),
                PhoneNumber="21354354885",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
        };
        List<PersonModel> IPersonService.GetAll()
        {
            return _people;
        }

        public PersonModel? GetOne(int index)
        {
            throw new NotImplementedException();
        }

        public PersonModel Create(PersonModel model)
        {
            _people.Add(model);
            return model;
        }

        public PersonModel? Update(int index, PersonModel model)
        {
            if (index >= 0 && index < _people.Count)
            {
                _people[index]=model;
                return model;
            }

            return null;
        }

        public PersonModel? Delete(int index)
        {
            if (index >= 0 && index < _people.Count)
            {
                var person = _people[index];
                _people.RemoveAt(index);
                return person;
            }

            return null;
        }
    }
}
