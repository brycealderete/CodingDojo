const faker = require('faker');

class Fake {
    constructor() {
        this.message = faker.hacker.phrase();
        this.image = faker.image.avatar();
        this.email = faker.internet.email();
        this.name = `${faker.name.title()} ${faker.name.firstName()} ${faker.name.lastName()}`;
    }
}

// Investor Markets Liaison Vito Brakus

module.exports = Fake;