describe("hrmlogintest", () => {
  before(function(){

    cy.visit("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
  })
it("Validating with valid creds", () => {
  

  
  cy.get(':nth-child(2) > .oxd-input-group > :nth-child(2) > .oxd-input').type('Admin')
  cy.get(':nth-child(3) > .oxd-input-group > :nth-child(2) > .oxd-input').type('admin123')
  cy.get('.oxd-button').click();
  cy.contains('leave',{matchCase:false}).click()
  cy.get('.oxd-topbar-body').contains('Apply').click();
  

  
  });
  /*it("Validating with valid invalid creds", () => {
  

    cy.visit("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
    cy.get(':nth-child(2) > .oxd-input-group > :nth-child(2) > .oxd-input').type('Admin')
    cy.get(':nth-child(3) > .oxd-input-group > :nth-child(2) > .oxd-input').type('admin1234')
    
    cy.contains('leave',{matchCase:false}).click()
    cy.get('.oxd-topbar-body').contains('Apply').click();

    });*/
});
