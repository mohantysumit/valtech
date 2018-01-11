# Valtech Test Suite

### Test Execution

Tests must be executed through the Visual Studio Test Explorer.
Requires the NUnit and SpecFlow extensions.

### Test Suite Summary

Tests follow BDD style Cucumber using features and scenarios executing step definitions, used POM model for Home page

Selenium web driver is used to interact with the web page, hooks are utilised to prepare the web browser for execution and close the browser

Step definitions are intended to be small and lean with page logic contained in the page objects 

Scenario steps were created with the intent of being used elsewhere in the suite 

### Considerations

Due to limited amount of time some aspects of testing could not be achieved like making the url as environment specific, this has been hard coded in home page

Ideally the environment settings like url would exist in their own test data file and be used by framework in the environment its being tested on

Page objects were not setup for About/Services/Work pages as it was not necessary for test coverage as desired

There is no reporting setup due to time constraints meaning the tests must be run through the NUnit test adaptor, though this would be changed using a 3rd party reporting library