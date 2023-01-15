import {AbstractControl, FormGroup, ValidationErrors, ValidatorFn} from "@angular/forms";

// ! this validator validates if two input fields have same value
export function inputFieldsMatch(firstInput: string, secondInput: string): ValidatorFn{
  return (control: AbstractControl): ValidationErrors | null => {
    const formGroup = control as FormGroup
    const valueA = formGroup.get(firstInput)?.value
    const valueB = formGroup.get(secondInput)?.value

    if (valueA === valueB){
      return null
    }
    else{
      return {valuesDoesNotMatch: true}
    }
  }
}
