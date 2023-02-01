
describe('Tutorialspoint Test',{
  viewportHeight: 1000,
  viewportWidth: 1600,
}, function ()  {
    // test case
   
      it
      ('Snenario rahul shetty alert', function(){

          const purl=cy.visit("https://rahulshettyacademy.com/AutomationPractice/");
         cy.get('#alertbtn').click()
         cy.on('window:alert',function(str){
          expect(str).to.equal("Hello , share this practice page and share your knowledge");
         })

        
      
         cy.get('#opentab').invoke('removeAttr','target').click()
         cy.url().should('include','rahulshettyacademy');
        // cy.go('back');
       // cy.get('.nav-outer > .main-menu > .navbar-collapse > .navigation > .dropdown > .dropdown-toggle').trigger('More').should('have.length','1').should('have.a.text','More').click();
        cy.get('.nav-outer > .main-menu > .navbar-collapse > .navigation > .dropdown > .dropdown-toggle').invoke('show')
        cy.get('.nav-outer > .main-menu > .navbar-collapse > .navigation > .dropdown > .dropdown-toggle').should('have.length','1');
        cy.contains('Contact').click({ force: true })
        cy.go('back');   // back to more 

      })
      it('parent window ', function(){
       
        cy.visit("https://rahulshettyacademy.com/AutomationPractice/")
        cy.url().should('include','https://rahulshettyacademy.com/AutomationPractice/');
        //cy.get('select').should('have.length','3')
        cy.get('select').select('Option1');
        cy.get('select').select('Option3');
        cy.frameLoaded('#courses-iframe');
        cy.get('.oxd-userdropdown-tab').select()
       // cy.iframe().find("").then(function(t){
          //const frmtxt = t.text()
          //expect(frmtxt).to.contains('Courses');
          //t.click();
        })
      

      })
      
  
    
    
 
