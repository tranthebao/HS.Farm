import { Component, Injector, ViewChild } from '@angular/core';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { CayTrongServiceProxy, CayTrongDto, PagedResultDtoOfCayTrongDto } from '@shared/service-proxies/service-proxies';

import { PagedListingComponentBase, PagedRequestDto } from "shared/paged-listing-component-base";
import { EditCayTrongComponent } from "app/Farm/caytrong/edit-caytrong/edit-caytrong.component";
import { CreateCayTrongComponent } from "app/Farm/caytrong/create-caytrong/create-caytrong.component";

@Component({
    templateUrl: './caytrongs.component.html',
    animations: [appModuleAnimation()]
})
export class CayTrongComponent extends PagedListingComponentBase<CayTrongDto> {

    @ViewChild('createCayTrongModal') createCayTrongModal: CreateCayTrongComponent;
    @ViewChild('editCayTrongModal') editCayTrongModal: EditCayTrongComponent;

    caytrongs: CayTrongDto[] = [];

    constructor(
        injector: Injector,
        private _cayTrongService: CayTrongServiceProxy
    ) {
        super(injector);
    }

    list(request:PagedRequestDto, pageNumber:number, finishedCallback: Function): void {
        this._cayTrongService.getAll(request.skipCount, request.maxResultCount)
            .finally(()=>{
                finishedCallback();
            })
            .subscribe((result:PagedResultDtoOfCayTrongDto)=>{
				this.caytrongs = result.items;
				this.showPaging(result, pageNumber);
            });
    }

    delete(caytrong: CayTrongDto): void {
		abp.message.confirm(
			"Delete caytrong '"+ caytrong.name +"'?",
			(result:boolean) => {
				if(result) {
					this._cayTrongService.delete(caytrong.id)
						.finally(() => {
					        abp.notify.info("Deleted caytrong: " + caytrong.name );
							this.refresh();
						})
						.subscribe(() => { });
				}
			}
		);
    }

    // Show modals
    createcaytrong(): void {
        this.createCayTrongModal.show();
    }

    editcaytrong(caytrong:CayTrongDto): void{
        this.editCayTrongModal.show(caytrong.id);
    }
}