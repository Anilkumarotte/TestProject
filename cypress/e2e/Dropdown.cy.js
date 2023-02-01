describe('Tutorialspoint', function () {
    // it function to identify test
    it('Scenario 1', function (){
       // test step to launch a URL
       cy.visit("https://register.rediff.com/register/register.php")
       //select option India with value then verify with assertion
       cy.get('select[id="country"]').select('12').should('have.value', '12')
    })
 })