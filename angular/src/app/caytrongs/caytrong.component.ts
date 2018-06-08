// tslint:disable-next-line:whitespace
import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { CayTrongServiceProxy, CayTrongDto, PagedResultDtoOfCayTrongDto } from '@shared/service-proxies/service-proxies';

import { PagedListingComponentBase, PagedRequestDto } from '@shared/paged-listing-component-base';
import { EditCayTrongComponent } from '@app/caytrongs/edit-caytrong/edit-caytrong.component';
import { CreateCayTrongComponent } from '@app/caytrongs/create-caytrong/create-caytrong.component';

@Component({
    templateUrl: './caytrong.Component.html',
    animations: [appModuleAnimation()]
})
export class CayTrongComponent extends PagedListingComponentBase<CayTrongDto> {
    @ViewChild('createCayTrongModal') createCayTrongModal: CreateCayTrongComponent;
    @ViewChild('editCayTrongModal') editCayTrongModal: EditCayTrongComponent;

    caytrongs: CayTrongDto[] = [];

    constructor(
        injector: Injector,
        private _caytrongService: CayTrongServiceProxy
    ){
        super(injector);
    }

    list(request: PagedRequestDto, pagedNumber: number, fishedCallback: Function): void {
        this._caytrongService.getAll(null, request.skipCount, request.maxResultCount)
            .finally(() => {
                fishedCallback();
            })
            .subscribe((result: PagedResultDtoOfCayTrongDto) => {
                this.caytrongs = result.items;
                this.showPaging(result, pagedNumber);
            });
    }

    delete(caytrong: CayTrongDto): void {
        abp.message.confirm(
            'Delete cay trong:' + caytrong.id + '?',
            (result: boolean) => {
                if ( result ) {
                    this._caytrongService.delete(caytrong.id)
                        .finally(() => {
                            abp.notify.info('Delete cay trong:' + caytrong.id);
                            this.refresh();
                        })
                        .subscribe(() => {

                        });
                }
            }
        )
    }

    createCayTrong(): void {
        this.createCayTrongModal.show();
    }

    editCayTrong(caytrong: CayTrongDto): void {
        this.editCayTrongModal.show(caytrong.id);
    }

}
