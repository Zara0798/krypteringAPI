# EnkrypteringAPI

## Overview
EnkrypteringAPI is a simple API built in .NET Core that provides encryption and decryption functionality. The API reverses input strings for both encryption and decryption, demonstrating basic functionality.

This project was created as part of an individual CI/CD examination assignment, and it includes deployment to AWS Elastic Beanstalk using GitHub Actions.

---

## API Endpoints

### Encrypt a Text
**URL**:  
`http://enkrypteringapi-env.eba-2vkwhewk.eu-north-1.elasticbeanstalk.com/Hello/Encrypt?input=<your-text>`

**Method**:  
GET

**Parameters**:  
- `input` (string): The text you want to encrypt.

**Example**:  
`http://enkrypteringapi-env.eba-2vkwhewk.eu-north-1.elasticbeanstalk.com/Hello/Encrypt?input=HelloWorld`

**Response**:  
```json
{
    "input": "HelloWorld",
    "encrypted": "dlroWolleH"
}
