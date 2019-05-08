import { GoldDeliveryTemplatePage } from './app.po';

describe('GoldDelivery App', function() {
  let page: GoldDeliveryTemplatePage;

  beforeEach(() => {
    page = new GoldDeliveryTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
