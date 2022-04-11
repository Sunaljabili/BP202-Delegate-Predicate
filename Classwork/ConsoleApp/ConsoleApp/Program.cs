using ConsoleApp.Exceptions;
using ConsoleApp.mODELS;
using ConsoleApp.Models;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy(4);

            Medicine medicine = new Medicine
            {
                Count = 2,
                Name = "Bash agrisi",
                IsDeleted = false,
                Price = 20
            };
            Medicine medicine2 = new Medicine
            {
                Count = 4,
                Name = "Bash agrisi2",
                IsDeleted = true,
                Price = 120
            };
            Medicine medicine3 = new Medicine
            {
                Count = 5,
                Name = "Dish agrisi",
                IsDeleted = false,
                Price = 20
            };

            try
            {
                pharmacy.AddMedicine(medicine);
                pharmacy.AddMedicine(medicine2);
                //pharmacy.GetMedicineById(null);
                //pharmacy.DeleteMedicineById(null);
                pharmacy.EditMedicineEmail(1, "Salam olsun BP202 ushaglarina");
                Console.WriteLine(medicine.Name);

            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            catch (MedicineAlreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
