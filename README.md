# Drone Photos

## TODO
- Fix the DbContext
  - https://chrissainty.com/securing-your-blazor-apps-introduction-to-authentication-with-blazor/
  - https://stackoverflow.com/questions/19902756/asp-net-identity-dbcontext-confusion
  - https://stackoverflow.com/questions/43767933/entity-framework-core-using-multiple-dbcontexts
- Repository Pattern
  - https://codewithmukesh.com/blog/repository-pattern-in-aspnet-core/
  - https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-implementation-entity-framework-core
- Create DB if not exists
  https://stackoverflow.com/questions/54966195/mysql-ef6-and-database-createifnotexists
- Add user roles
  - https://learn.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-8.0
  - https://www.syncfusion.com/faq/blazor/general/how-do-you-implement-role-based-authorization-in-blazor
  - https://stackoverflow.com/questions/63444809/blazor-identity-add-roles-on-application-startup
  - https://auth0.com/blog/role-based-access-control-in-blazor-apps/
  - https://blazorhelpwebsite.com/ViewBlogPost/21
  - https://stackoverflow.com/questions/75586668/how-do-i-use-the-user-roles-from-the-azure-app-service-authentication-feature-in#comment133368280_75586668
- Create an admin login with access to image management
  - https://learn.microsoft.com/en-us/azure/role-based-access-control/role-assignments-portal-subscription-admin
  - https://stackoverflow.com/questions/75586668/how-do-i-use-the-user-roles-from-the-azure-app-service-authentication-feature-in
- Create image uploads with blob pages
  - https://learn.microsoft.com/en-us/azure/event-grid/storage-upload-process-images?tabs=azure-cli
  - https://learn.microsoft.com/en-us/azure/storage/blobs/blob-upload-function-trigger?tabs=azure-portal
  - https://stackoverflow.com/questions/31531026/saving-images-in-azure-storage
  - https://blazor.syncfusion.com/documentation/file-upload/getting-started
- Create App Service 
- Try manual deployments to see if EF works
- Replace the workflow
  - https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel%2Caspnetcore
  - https://stackoverflow.com/questions/68058223/how-to-deploy-a-net-core-solution-with-multiple-web-apps-to-azure-using-github
- Get Entity Framework Migrations working with workflow
  - https://learn.microsoft.com/en-us/azure/azure-sql/database/connect-github-actions-sql-db?view=azuresql&tabs=userlevel
  - https://learn.microsoft.com/en-us/azure/devops/pipelines/targets/azure-sqldb?view=azure-devops&tabs=yaml
  - https://stackoverflow.com/questions/59234655/apply-ef-migrations-in-github-workflow
  - Look into the .deployment file or WEBSITE_RUN_FROM_PACKAGE
    - https://github.com/projectkudu/kudu/wiki/Custom-Deployment-Script https://docs.microsoft.com/bs-latn-ba/azure/azure-functions/run-functions-from-deployment-package
- Azure
  - App Service
  - Application Insights
  - App Service availability test
  - App service logs - Turn on all error logging
  - SQL Server
  - Connect App service to SQL Server
    - Just a connection string? 
    - System assigned identities for talking to DB?
    - Look into service connectors
    - Identity provider settings in App Service
  - Deployment Slots
    - Blue green deployment
  - Azure AD or OAuth
  - Redis
  - Frontdoor
  - Bicep or ARM
- Add Unit Tests to workflow
- Dependabot
  - https://medium.com/@nickfane/integrating-dependabot-into-your-net-core-project-on-github-3e3024bd3394
  - Play with JsInterop
  - https://www.yogihosting.com/blazor-js-interop-javascript/
  - https://github.com/google/j2cl/blob/master/docs/jsinterop-by-example.md
  - https://dev.to/rasheedmozaffar/intro-to-js-interop-in-blazor-46mo
  - https://blazor-university.com/javascript-interop/
- Allow folders to be created, moved and deleted
- Upload images to selected blob folder 
- Enable images to be moved
- Implement Masonry.js
  - https://masonry.desandro.com/
- Display images
- Put it in Docker 
- Unit tests (include in workflow)
  - NUnit
  - Moq
  - FluentValidation
  - AutoFixture
  - Fakeiteasy
  - NSubstitute
  - Dapper
- Deployment slots
  - Update workflow to switch between deployment slots
  - 
- MediatR

## Optional Things
- Add Azure App Configuration
  - https://learn.microsoft.com/en-us/azure/azure-app-configuration/quickstart-aspnet-core-app
- Add Feature Management
  - https://learn.microsoft.com/en-us/azure/azure-app-configuration/concept-feature-management
- Event Grid

## Useful Links
- JS Component Library
  - https://ui.shadcn.com/docs/installation/

## Completed
- Skeleton Site
- Create Github repo and attach it to the site
- Enable CICD using Azure
- Remove Azure/GitHub CICD and create it manually
  - https://learn.microsoft.com/en-us/azure/app-service/deploy-github-actions?tabs=applevel%2Caspnetcore
- Upgrade to .NET 8
- Add Microsoft Identity to connect to Blazor's built in authentication pages
  - https://chrissainty.com/securing-your-blazor-apps-introduction-to-authentication-with-blazor/
- Add appsettings.development.json to .gitignore and remove it from repository
  - https://stackoverflow.com/questions/7927230/remove-directory-from-remote-repository-after-adding-them-to-gitignore
  - https://www.git-tower.com/learn/git/faq/ignore-tracked-files-in-git
  - https://www.baeldung.com/ops/git-remove-tracked-files-gitignore
- Configure emails for registration confirmation & password resets - Gmail (Mailtrap is another alternative)
  - https://medium.com/@abhinandkr56/how-to-send-emails-using-net-core-mailkit-and-googles-smtp-server-6521827c4198
  - https://jasonwatmore.com/post/2022/03/11/net-6-send-an-email-via-smtp-with-mailkit
- Turn on Pull Requests only for the main branch in GitHub


## Markdown Cheatsheets
https://www.markdownguide.org/basic-syntax/#ordered-lists  
https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet  
https://github.com/tchapi/markdown-cheatsheet/blob/master/README.md

## Purpose of this app
Upload and display drone photos