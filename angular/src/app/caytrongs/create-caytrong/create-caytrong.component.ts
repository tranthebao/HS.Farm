import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef, EmbeddedViewRef } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { CayTrongServiceProxy, CayTrongDto } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';

@Component({
    selector: 'create-caytrong-modal',
    templateUrl: './create-caytrong.component.html'
})

export class CreateCayTrongComponent extends AppComponentBase {
    @ViewChild('createCayTrongModal') modal: ModalDirective;
    @ViewChild('modalContent') modalContent: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active = false;
    saving = false;
    caytrong: CayTrongDto = null;

    constructor(injector: Injector, private _cayTrongService: CayTrongServiceProxy){
        super(injector);
    }

    show(): void {
        this.active = true;
        this.modal.show();
        this.caytrong = new CayTrongDto();
        this.caytrong.init({isActive: true})
    }

    onShown(): void {
        $.AdminBSB.input.activate($(this.modalContent.nativeElement));
    }

    save(): void {
        this.saving = true;
        this._cayTrongService.create(this.caytrong)
            .finally(() => {
                this.saving = false;
            })
            .subscribe(() => {
                this.notify.info(this.l('SaveSuccessfully'));
                this.close();
                this.modalSave.emit(null);
            })
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }

}