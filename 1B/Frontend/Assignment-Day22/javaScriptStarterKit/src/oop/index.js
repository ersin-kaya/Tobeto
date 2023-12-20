// export -> public
class Customer{
    constructor(id, customerNumber){
        this.id = id
        this.customerNumber = customerNumber
    }
}

let customer = new Customer(1, "12345")
console.log(customer);
console.log(customer.id); 
console.log(customer.customerNumber); 

// prototyping for instance
customer.name = "Murat Kurtboğan"
console.log(customer.name);

// prototyping for class
Customer.anything = "Anything"

console.log(Customer.anything);
console.log(customer.anything); // class'a yapılan proto...'e instance'tan erişemiyoruz // undefined dönüyor


class IndividualCustomer extends Customer {
    constructor(firstName, id, customerNumber){
        super(id,customerNumber)
        this.firstName = firstName
    }
}

class CorporateCustomer extends Customer {
    constructor(companyName, id, customerNumber){
        super(id,customerNumber)
        this.companyName = companyName
    }
}

