using ConsoleApp.Exceptions;
using ConsoleApp.mODELS;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Models
{
     public class Pharmacy
    {
        public int MedicineLimit { get; set; }
        public List<Medicine> Medicines = new List<Medicine>();

        public Pharmacy(int medicineLimit)
        {
            MedicineLimit = medicineLimit;
        }
        public void AddMedicine(Medicine medicine)
        {
            if (Medicines.Exists(x => x.Name == medicine.Name))
                throw new MedicineAlreadyExistsException("Bu dermandan var");

            if (Medicines.Count< MedicineLimit)
            {
                Medicines.Add(medicine);
            }
            else
            {
                throw new CapacityLimitException("Limiti ashdiniz");
            }
            

        }
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> CopyMedicine = new List<Medicine>();
            CopyMedicine.AddRange(Medicines.FindAll(x => x.IsDeleted == false));
            return CopyMedicine;
        }

        public List<Medicine> FilterMedicinesByPrice(double MinPrice,double maxPrice)
        {
           return Medicines.FindAll(x => x.Price > MinPrice && x.Price < maxPrice);
        }

        public Medicine GetMedicineById(int ? id)
        {
            if (id==null)
            {
                throw new NullReferenceException("Bele NULL derman yoxdur");
            }
           return  Medicines.Find(x => x.Id == id && x.IsDeleted == false);

        }

        public void DeleteMedicineById(int? id)
        {
            if (id==null)
                throw new NullReferenceException("Xeta bash verdi null");
            if (Medicines.Exists(x => x.Id == id && x.IsDeleted == false))
            {
                Medicines.Find(x => x.Id == id && x.IsDeleted == false).IsDeleted = true;
            }
            else
            {
                throw new NotFoundException("tAPILMADI");
            }
        }
        public void EditMedicineEmail(int? id ,string name)
        {
            if (id == null || string.IsNullOrWhiteSpace(name)){
                throw new NullReferenceException("Xeta bash verdi EditMedicineEmail");
            }
            if (!Medicines.Exists(x => x.Id == id && x.IsDeleted == false))

            {
                throw new NotFoundException("Deyter tapilmadi not foundun exceptionu");
            }
            else
            {
                Medicines.Find(x => x.Id == id && x.IsDeleted == false).Name = name;
            }

        }




    }
}
