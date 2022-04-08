export class Employee
{
    constructor(_jsonEmployee, _currencySalary, _mailSuffix)
    {
        ({
            id: this.id,
            employee_name: this.fullName,
            employee_age: this.age,
            employee_salary: this.annualSalary,
            profile_image: this.profileImage
        } = _jsonEmployee);
        this.currencySalary = _currencySalary;
        this.mailSuffix = _mailSuffix;
        this.firstName = this.getFirstName();
        this.lastName = this.getLastName();
        this.email = this.getEmail();
        this.birthYear = this.getYearBirth();
        this.monthlySalary = this.getSalaryPerMonth();
    }

    getFirstName()
    {
        return this.fullName.split(" ")[0];
    }

    getLastName()
    {
        return this.fullName.split(" ")[1];
    }

    getEmail()
    {
        let firstName = this.getFirstLetterFirstName().toLowerCase();
        let lastName = this.getLastName().toLowerCase();

        return firstName + '.' + lastName + '@' + this.mailSuffix;
    }

    getSalaryPerMonth()
    {
        return parseFloat(parseFloat(this.annualSalary) / 12).toFixed(2);
    }

    getYearBirth()
    {
        let currentDate = new Date();

        return currentDate.getFullYear() - this.age;
    }

    getFirstLetterFirstName()
    {
        return this.getFirstName().charAt(0);
    }
};
