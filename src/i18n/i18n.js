import i18n from 'i18next';
import { initReactI18next } from 'react-i18next';
 
import Backend from 'i18next-http-backend';
import LanguageDetector from 'i18next-browser-languagedetector';


// const CookieOptions = {
//   httpOnly: true,
//   secure: true,
  
// }
const i18nextOptions = {
    order: ['querystring', 'cookie', 'localStorage', 'sessionStorage', 'navigator', 'htmlTag'],
    lookupQuerystring: 'lng',
    lookupCookie: 'i18next',
    lookupLocalStorage: 'i18nextLng',
    lookupSessionStorage: 'i18nextLng',
    caches: ['localStorage','cookie'],
    excludeCacheFor: ['cimode'],
    cookieMinutes:10,
    htmlTag:document.documentElement,
    cookieOptions:{
      path:'/',
      httpOnly: true,
      secure: true,
      sameSite : 'strict'
    },
    
    
    //cookieDomain: 'myDomain'
}

i18n
  // load translation using http -> see /public/locales (i.e. https://github.com/i18next/react-i18next/tree/master/example/react/public/locales)
  // learn more: https://github.com/i18next/i18next-http-backend
  .use(Backend)
  // detect user language
  // learn more: https://github.com/i18next/i18next-browser-languageDetector
  .use(LanguageDetector)
  // pass the i18n instance to react-i18next.
  .use(initReactI18next)
  
  // init i18next
  // for all options read: https://www.i18next.com/overview/configuration-options
  
  .init({
    detection: i18nextOptions,
    backend: {
      /* translation file path */
      loadPath: '/assets/i18n/{{ns}}/{{lng}}.json'
    },
    fallbackLng:'kn',
    lng: sessionStorage.getItem("language") || "kn",
    debug: true,
    /* can have multiple namespace, in case you want to divide a huge translation into smaller pieces and load them on demand */
    ns: ['translations'],
    defaultNS: 'translations',
    keySeparator: '.',
    interpolation: {
      escapeValue: false,
      formatSeparator: ','
    },
    react: {
      wait: true
    }
  });



export default i18n;