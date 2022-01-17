```python
import requests
import json

def fetch_quote():
    response = requests.get("https://quotes.rest/qod")
    data = json.loads(response.text)
    quote = data['contents']['quotes'][0]['quote']
    author = data['contents']['quotes'][0]['author']
    return f'"{quote}" - {author}'

if __name__ == "__main__":
    print(fetch_quote())
```