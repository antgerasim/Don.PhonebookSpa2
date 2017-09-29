# Don.PhonebookSpa2

https://stackoverflow.com/questions/39677437/how-to-update-typescript-to-latest-version-with-npm

How to fix webpack compiler error? - After executing nswag/refresh.bat the generated service-proxies
are currupted.

1. Comment out the duplicate of  import * as moment from 'moment';
2. Add import 'rxjs/add/operator/finally';
3. In each component (create-role.component.ts, create-tenant.component.ts, create-user.component.ts) add 'as any 



