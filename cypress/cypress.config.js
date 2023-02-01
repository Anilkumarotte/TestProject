const { defineConfig } = require("cypress");

module.exports = defineConfig({
  projectId: 'e2ngak',
  e2e: {
    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});
