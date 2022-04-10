export class EmployeeTableFactory
{
    constructor(_tableElement, _employeeApi)
    {
        this.table = _tableElement;
        this.employeeApi = _employeeApi;
        this.virtualTable = document.createDocumentFragment();
        this.numberRow = 0;
    }

    addEmployeeRow(_employee)
    {
        let buttons = [];

        buttons.push(this.getActionDuplicateButton(_employee.id));
        buttons.push(this.getActionDeleteButton(_employee.id));

        this.addRow(
            `employee_${_employee.id}`,
            _employee.id,
            _employee.fullName,
            _employee.email,
            `${_employee.monthlySalary} ${_employee.currencySalary}`,
            _employee.birthYear,
            buttons
        );
    }

    addTotalMontlySalaryRow()
    {
        this.addRow(
            `employee_total_monthly_salary`,
            this.employeeApi.getAllEmployees().length,
            "",
            "",
            `${this.employeeApi.totalMonthlySalary} ${this.employeeApi.salaryCurrency}`,
            "",
            ""
        );
    }

    addRow(
        _idRow,
        _eidCell,
        _fullNameCell,
        _emailCell,
        _monthlySalaryCell,
        _yearBirthCell,
        _actionsCell
    ) {
        let row = document.createElement("tr");

        row.setAttribute('id', _idRow);

        for (let argIndex = 1; argIndex < arguments.length - 1; argIndex++) {
            this.addCell(row, arguments[argIndex]);
        }

        this.addCell(row, "", _actionsCell);

        this.virtualTable.appendChild(row);
        this.numberRow++;
    }

    addCell(_row, _value = "", _childNodes = [])
    {
        let cell = document.createElement("td");
        if (_value != "") {
            cell.textContent = _value;
        }
        if (_childNodes.length != 0) {
            _childNodes.forEach(node => cell.appendChild(node));
        } 
        _row.appendChild(cell);
    }

    getActionDuplicateButton(_employeeId)
    {
        return this.getActionButton("Duplicate", "employeeActionDuplicate", _employeeId, this.eventActionDuplicate)
    }

    getActionDeleteButton(_employeeId)
    {
        return this.getActionButton("Delete", "employeeActionDelete", _employeeId, this.eventActionDelete)
    }

    getActionButton(_label, _className, _employeeId, _functionOnEvent)
    {
        let button = document.createElement("button");

        button.textContent = _label;
        button.classList.add(_className);
        button.dataset.employeeId = _employeeId;
        button.setAttribute("type", "button");
        button.addEventListener('click', (event) => {
            _functionOnEvent(event, this);
        });

        return button;
    }

    generate()
    {
        this.employeeApi.getAllEmployees().forEach(employee => {
            this.addEmployeeRow(employee);
        });

        this.addTotalMontlySalaryRow();

        this.table.querySelector("tbody").appendChild(this.virtualTable);
    }

    
    eventActionDuplicate(_event, _that)
    {
        let currentIdEmployee = _event.currentTarget.dataset.employeeId;
        let currentEmployee = _that.employeeApi.getEmployee(currentIdEmployee);
        let newId = _that.employeeApi.getIdForNewEmployee();
        _that.employeeApi.postEmployee(currentEmployee.duplicate(newId));
        _that.eventDeleteTable(_event, _that);
        _that.generate();
    }

    eventActionDelete(_event, _that)
    {
        let currentIdEmployee = _event.currentTarget.dataset.employeeId;
        _that.employeeApi.deleteEmployee(currentIdEmployee);
        _that.eventDeleteTable(_event, _that);
        _that.generate();
    }

    eventDeleteTable(_event, _that)
    {
        _event.currentTarget.parentNode.parentNode.parentNode.innerHTML = "";
        _that.numberRow = 0;
    }
};
