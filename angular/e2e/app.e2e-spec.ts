import { PhoneBookSpa2TemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: PhoneBookSpa2TemplatePage;

  beforeEach(() => {
    page = new PhoneBookSpa2TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
