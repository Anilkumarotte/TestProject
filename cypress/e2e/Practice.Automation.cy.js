describe('Automation', function () {
    // test case
    
        before(function(){

            cy.visit("https://practice.automationbro.com/")
            cy.url().should("include","automationbro.com")})

        
       //URL launched
     
     it("Verify the text of the first menu link item",function(){
        const menuLinksText=[
            "Home",
            "About",
            "Shop",
            "Blog",
            "Contact",
            "My account",
        ];
         cy.get("#primary-menu [id*=menu-item]").each((item, index, list) => {
            expect(list).to.have.length(6);
            cy.wrap(item).should("contain.text",menuLinksText[index]);

        })})
         
     



     })


 
          