describe('Tutorialspoint', function () {
    // it function to identify test
    it('Scenario 1', function (){
       // test step to launch a URL
       cy.visit("https://register.rediff.com/register/register.php")
       //select option India with value then verify with assertion
       cy.get('select[id="country"]').select('12').should('have.value', '12')
        
       ///Get dropdown text
        
           Dropdown.then(dropdown => {
        const dropdownoptions = dropdown.find('option');
        dropdownoptions.each((index, option) => {
          const dropdownoptionText = Cypress.$(option).text();
         cy.log(dropdownoptionText);
        
         });
        });
        ///get count 
        cy.get('.form-select') .invoke('children').its('length').then((count) => {              
            cy.log(`Number of items in the dropdown: ${count}`)
          });
        
    })
    
    
 })


