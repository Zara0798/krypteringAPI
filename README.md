# EnkrypteringAPI

## Overview
EnkrypteringAPI is a simple API built in .NET Core that provides encryption and decryption functionality. The API reverses input strings for both encryption and decryption, demonstrating basic functionality.

This project was created as part of an individual CI/CD examination assignment, and it includes deployment to AWS Elastic Beanstalk using GitHub Actions.

---

## API Endpoints

### Decrypt a Text
**URL**:  
`http://enkrypteringapi-env.eba-2vkwhewk.eu-north-1.elasticbeanstalk.com/Hello/Decrypt?encrypted=<your-encrypted-text>`

**Method**:  
GET

**Parameters**:  
- `encrypted` (string): The encrypted text you want to decrypt.

**Example**:  
`http://enkrypteringapi-env.eba-2vkwhewk.eu-north-1.elasticbeanstalk.com/Hello/Decrypt?encrypted=dlroWolleH`

**Response**:  
```json
{
    "encrypted": "dlroWolleH",
    "decrypted": "HelloWorld"
}
```

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
```

---

## Deployment

The application is deployed on **AWS Elastic Beanstalk** using **GitHub Actions**. The deployment process includes:

- Building the project.
- Zipping the build files.
- Uploading the package to AWS Elastic Beanstalk.

### Live Application URL:
**Base URL**:  
[http://enkrypteringapi-env.eba-2vkwhewk.eu-north-1.elasticbeanstalk.com](http://enkrypteringapi-env.eba-2vkwhewk.eu-north-1.elasticbeanstalk.com)

---

## How to Run Locally

1. **Clone the repository**:  
   ```bash
   git clone <repository-url>
   ```
2. **Open the solution in Visual Studio**
3. **Restore dependencies:**  
   ```bash
   dotnet restore
   ```
4. **Run the project:**  
   ```bash
   dotnet run
   ```
5. **Access the API in your browser:**  
   ```
   https://localhost:7018/Hello/Encrypt?input=HelloWorld
   ```

---

## CI/CD Pipeline

The CI/CD pipeline is implemented using GitHub Actions and includes the following steps:

1. **Code Checkout**: Pulls the latest code from the main branch.
2. **Build and Publish**: Builds and publishes the project to a zip file.
3. **Deploy to AWS**: Deploys the zip file to AWS Elastic Beanstalk.

### Repository Secrets

The following secrets are configured for deployment:

- **AWS_ACCESS_KEY_ID**
- **AWS_SECRET_ACCESS_KEY**
- **AWS_REGION**
- **APPLICATION_NAME**
- **ENVIRONMENT_NAME**

