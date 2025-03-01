// Implement ContactManager class
class ContactManager {
    constructor() {
        this.contacts = [];
    }
    // Add a new contact
    addContact(contact) {
        this.contacts.push(contact);
        console.log(`Contact added successfully: ${contact.name}`);
    }
    // View all contacts
    viewContacts() {
        return this.contacts;
    }
    // Modify an existing contact
    modifyContact(id, updatedContact) {
        const contact = this.contacts.find(c => c.id === id);
        if (!contact) {
            console.log(`Error: Contact with ID ${id} not found.`);
            return;
        }
        Object.assign(contact, updatedContact);
        console.log(`Contact modified successfully: ${contact.name}`);
    }
    // Delete a contact
    deleteContact(id) {
        const index = this.contacts.findIndex(c => c.id === id);
        if (index === -1) {
            console.log(`Error: Contact with ID ${id} not found.`);
            return;
        }
        this.contacts.splice(index, 1);
        console.log(`Contact with ID ${id} deleted successfully.`);
    }
}
// Testing the ContactManager class
const manager = new ContactManager();
// Adding contacts
manager.addContact({ id: 1, name: "John Doe", email: "john@example.com", phone: "123-456-7890" });
manager.addContact({ id: 2, name: "Jane Doe", email: "jane@example.com", phone: "987-654-3210" });
// Viewing contacts
console.log("All Contacts:", manager.viewContacts());
// Modifying a contact
manager.modifyContact(1, { phone: "111-222-3333" });
// Deleting a contact
manager.deleteContact(2);
// Viewing contacts after modification and deletion
console.log("Updated Contacts:", manager.viewContacts());
