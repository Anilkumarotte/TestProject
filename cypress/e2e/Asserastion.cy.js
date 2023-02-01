describe('Tutorialspoint', function () {

    it('Scenario 1', function (){
       // test step to launch a URL
       cy.visit("https://www.tutorialspoint.com/videotutorials/index.php")
         // assertion to validate count of sub-elements and class attribute value
         cy.get('.toc chapters').find('li').should('have.length',5)
         .and('have.class', 'dropdown')
         
    });
 });