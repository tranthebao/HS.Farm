import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef} from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { CayTrongServiceProxy, CayTrongDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
  selector: 'edit-tenant-modal',
  templateUrl: './edit-tenant.component.html'
})
export class EditCayTrongComponent extends AppComponentBase{

    @ViewChild('editCayTrongModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active: boolean = false;
    saving: boolean = false;
    tenant: CayTrongDto = null;

    constructor(
        injector: Injector,
        private _cayTrongService: CayTrongServiceProxy
    ) {
        super(injector);
    }

    show(id:number): void {
		this._cayTrongService.get(id)
			.finally(()=>{
				this.active = true;
				this.modal.show();
			})
			.subscribe((result: CayTrongDto)=>{
				this.tenant = result;
			});
    }

    onShown(): void {
        $.AdminBSB.input.activate($(this.modalContent.nativeElement));
    }

    save(): void {
        this.saving = true;
        this._cayTrongService.update(this.tenant)
            .finally(() => { this.saving = false; })
            .subscribe(() => {
                this.notify.info(this.l('SavedSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}