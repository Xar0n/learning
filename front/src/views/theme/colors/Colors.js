import PropTypes from 'prop-types'
import * as signalR from '@microsoft/signalr'
import React, { useEffect, useState, createRef } from 'react'
import classNames from 'classnames'
import { CRow, CCol, CCard, CCardHeader, CCardBody, CTooltip, CButton } from '@coreui/react'
import { cilList, cilShieldAlt } from '@coreui/icons'
import { rgbToHex } from '@coreui/utils'
import { DocsLink } from 'src/components'
import Notifier from 'react-desktop-notification'

const Colors = () => {
  let connection = new signalR.HubConnectionBuilder()
    .withAutomaticReconnect()
    .withUrl('https://localhost:7162/notifications')
    .build()
  connection.on('ReceiveNotification', (data) => {
    console.log(data)
    Notifier.start('Уведомление', data)
  })
  connection.start()

  return (
    <>
      <CCard className="mb-4">
        <CCardHeader>Theme colors</CCardHeader>
        <CCardBody>
          <CRow>
            <CCol sm={1}>
              <CTooltip
                content={
                  <div>
                    <a href="">Привет</a>
                    <br />
                    Пока
                  </div>
                }
                placement="bottom"
                trigger={'click'}
              >
                <div>+</div>
              </CTooltip>
            </CCol>
          </CRow>
          <CRow>
            <CCol sm={8}>
              <div className="truncated-text">Сокращенный текст для проекта</div>
            </CCol>
          </CRow>
        </CCardBody>
      </CCard>
    </>
  )
}

export default Colors
