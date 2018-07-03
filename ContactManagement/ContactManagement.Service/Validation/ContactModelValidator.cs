using ContactManagement.Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ContactManagement.Service.Validation
{
    public class ContactModelValidator
    {
        IList<ValidationResult> _result;
        ContactApiModel _objectToValidate;

        public ContactModelValidator(ContactApiModel objectToValidate)
        {
            _result = new List<ValidationResult>();
            _objectToValidate = objectToValidate;
        }

        public IEnumerable<ValidationResult> Validate()
        {
            
            return (_result);
        }

        

    }
}
