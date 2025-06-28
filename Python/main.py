from scrape import scrape_website

url = ("https://www.kingsford.com/recipes/?utm_source=bing&utm_medium=cpc&utm_campaign=KFO%7CBranded%7CLT%7CP%7CKW%7CFood+%26+Recipes%7CEnglish%7CENKW-ENBR&utm_content=1228155518525683&utm_term=kingsford%20charcoal%20recipes&&msclkid=cb07bfe95aa614e7685cd7894ba3a1e1&utm_source=bing&utm_medium=cpc&utm_campaign=KFO%7CBranded%7CLT%7CP%7CKW%7CFood%20%26%20Recipes%7CEnglish%7CENKW-ENBR&utm_term=kingsford%20charcoal%20recipes&utm_content=General%7CGrilling%20Inspiration&gclid=cb07bfe95aa614e7685cd7894ba3a1e1&gclsrc=3p.ds&gad_source=7")
result = scrape_website(url)
print(result)

