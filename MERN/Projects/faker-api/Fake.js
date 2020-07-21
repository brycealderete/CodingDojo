const faker = require('faker');

class Fake {
    constructor() {
        this.firstName = faker.name.findName();
        this.lastName = faker.name.lastName();
        this.phoneNumber = faker.phone.phoneNumber();
        this.email = faker.internet.email();
        this.password = faker.internet.password();
    }
}

// Investor Markets Liaison Vito Brakus

module.exports = Fake;