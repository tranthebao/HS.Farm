import { FarmTemplatePage } from './app.po';

describe('Farm App', function() {
  let page: FarmTemplatePage;

  beforeEach(() => {
    page = new FarmTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
