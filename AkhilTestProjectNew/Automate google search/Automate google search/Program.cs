from selenium import webdriver
from selenium.webdriver.common.keys import Keys

# Create a new instance of the Chrome driver
driver = webdriver.Chrome()

# Open Google homepage
driver.get("https://www.google.com")

# Find the search box element and enter the search query
search_box = driver.find_element_by_name("q")
search_box.send_keys("automate Google search")
search_box.send_keys(Keys.RETURN)

# Wait for the search results to load
driver.implicitly_wait(5)

# Extract the search results
search_results = driver.find_elements_by_xpath('//div[@class="r"]/a/h3')

# Print the titles of the search results
for result in search_results:
    print(result.text)

# Close the browser
driver.quit()