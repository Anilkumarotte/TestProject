describe('Tutorialspoint Test', function () {
    // test case
    it("Scenario 1", function () {
       //URL launched
     cy.visit("https://the-internet.herokuapp.com/javascript_alerts")
 
     cy.get(':nth-child(1) > button').click()
     cy.on("window:alert", (t) => {
        expect(t).to.equal("I am a JS Alert");


     });

       });
       it("Scenario 1", function () {
        // URL launched
      
        //fire confirm browser event
        cy.on("window:confirm", (s) => {
           return false;
        });
        // click on Click for JS Confirm button
        cy.get(':nth-child(2) > button').click()
        // verify application message on Cancel button click
        cy.get('#result').should('have.text', 'You clicked: Cancel')
     });

     it("Scenario 1", function () {
        //URL launched
      cy.visit("https://the-internet.herokuapp.com/javascript_alerts")
  
      
      cy.on("window:alert", (t) => {
        cy.get(':nth-child(3) > button').type('wieufeuifgui')
        //expect(t).to.equal("I am a JS prompt");
     
      });
    })
    });
 
