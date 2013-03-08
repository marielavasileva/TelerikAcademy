using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace diplomna_rabota
{
    class NewMedicineValidationException : Exception {
    
        public NewMedicineValidationException(string msg) : base(msg)
        {

        }
    }

        class NewMedicineValidation
        {
            public static void validateMedicine(Drug obj)
            {
              if  (obj.GenericName.Trim() =="")

              {
                  throw new NewMedicineValidationException("Невалидно генерично име!");
              }

                if (obj.MedicineName.Trim() == "")
                {
                    throw new NewMedicineValidationException("Невалидно търговско име");
                }
                 
                if(obj.Producer.Trim() == "")
                {
                    throw new NewMedicineValidationException("Невалиден производител");
                }

                if(obj.MedForm.Trim() == "")
                {
                    throw new NewMedicineValidationException("Невалидна лекарствена форма");
                }

                 if(obj.NZOKCode.Trim() == "")
                {
                    throw new NewMedicineValidationException("Невалиден НЗОК код");
                }

                 if(obj.Action.Trim() == "")
                {
                    throw new NewMedicineValidationException("Невалиден механизъм на действие");
                }

                 if(obj.SideEffect.Trim() == "")
                {
                    throw new NewMedicineValidationException("Непопълнено поле: Нежелани лекарствени реакции");
                }

                  if( obj.ContraIndication.Trim() == "")
                {
                    throw new NewMedicineValidationException("Непопълнено поле: специални противопоказания");
                }

                  if(obj.MedicineDescrip.Trim() == "")
                {
                    throw new NewMedicineValidationException("Непопълнено поле: Кратка лекарствена характеристика");
                }

                /*if(obj.TerapyAgent!="")
                {
                    throw new NewMedicineValidationException("Непопълнено поле :Групи терапевтични агенти");
                }*/
            }

                 

        }
    }

    
   

       
