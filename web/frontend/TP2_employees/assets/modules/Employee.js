export class Employee
{
    constructor(id, name, age, salary, currencySalary, profile_image, mailSuffix = "email.com")
    {
        this.id = id;
        this.fullName = name;
        this.firstName = this.getFirstName();
        this.lastName = this.getLastName();
        this.mailSuffix = mailSuffix;
        this.email = this.getEmail();
        this.age = age;
        this.birthYear = this.getYearBirth();
        this.annualSalary = salary;
        this.monthlySalary = this.getSalaryPerMonth();
        this.currencySalary = currencySalary;
        this.profileImage = profile_image;
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
